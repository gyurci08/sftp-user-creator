using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sftp_user_creator.utils
{
    public class SftpUserGenerator
    {
        private static string CleanPath(string path)
        {
            return path.Trim().TrimEnd('/');
        }





        public string GenerateCommands(string username, string group, string password, string homePath, string[] subdirectories, string sshKey = null, string sshKeyPath = null)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(group) ||
                string.IsNullOrWhiteSpace(homePath))
            {
                throw new ArgumentException("Username, group, and home directory must be provided.");
            }

            homePath = CleanPath(homePath);
            sshKeyPath = CleanPath(sshKeyPath);

            var commands = new List<string>();

            homePath = homePath + $"/{username}";

            string sshHomePath = $"{sshKeyPath}/{username}";
            string sshPath = $"{sshHomePath}/.ssh";
            string authKeyPath = $"{sshPath}/authorized_keys";



            commands.Add($"# Username: {username}");
            commands.Add($"# Password: {password}");
            commands.Add($"# Home dir: {homePath}");

            commands.Add("\n# Directories");
            foreach (var subdir in subdirectories)
            {;
                string path = CleanPath($"{homePath}/{subdir}");

                commands.Add("");
                commands.Add($"mkdir -p {path}");
                commands.Add($"chown {username}:{group} {path}");
                commands.Add($"chmod 770 {path}");
            }

            if (!string.IsNullOrWhiteSpace(sshKey))
            {
                commands.Add("\n# Public-key authentication");
                commands.Add($"mkdir -p {sshPath}");
                commands.Add($"echo '{sshKey}' >> {authKeyPath}");
                commands.Add($"chown -R {username}:{group} {sshHomePath}");
                commands.Add($"chmod 700 {sshHomePath}");
                commands.Add($"chmod 644 {authKeyPath}");
            }


            commands.Add("\n# Validation");
            commands.Add($"getent passwd | grep '{username}:' && ll -d {homePath}");

            if (!string.IsNullOrWhiteSpace(sshKey))
            {
                commands.Add($"ll -d {authKeyPath}");
                commands.Add($"grep -q '{sshKey}' {authKeyPath} && echo 'Key found' || echo 'Key not found'");
            }

            commands.Add("\n# Diagnostic");
            commands.Add($"grep '{username}' /var/log/messages | tail");
            commands.Add($"grep -n1 {username}  "+ "$(ps -ef | grep 'sshd'| grep '\\-E' | grep -v 'grep' | awk '{print $13}')  | tail");

                return string.Join("\n", commands);
        }
    }


}
