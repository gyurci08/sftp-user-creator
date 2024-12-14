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

            commands.Add($"# Username: {username}");
            commands.Add($"# Password: {password}");
            commands.Add($"# Home dir: {homePath}");
            commands.Add($"groupadd {group}");
            commands.Add($"useradd -m -d {homePath} -g {group} -s /usr/sbin/nologin {username}");
            commands.Add($"echo '{username}:{password}' | chpasswd");


            foreach (var subdir in subdirectories)
            {;
                commands.Add("");
                string path = $"{homePath}/{subdir}";
                commands.Add($"mkdir -p {path}");
                commands.Add($"chown {username}:{group} {path}");
                commands.Add($"chmod 770 {path}");
            }

            if (!string.IsNullOrWhiteSpace(sshKey))
            {
                commands.Add("");
                commands.Add($"mkdir -p {sshKeyPath}/{username}/.ssh");
                commands.Add($"cat '{sshKey}' >> {sshKeyPath}/{username}/.ssh/authorized_keys");
                commands.Add($"chown -R {username}:{group} {sshKeyPath}/{username}/.ssh");
                commands.Add($"chmod 700 {sshKeyPath}/{username}/.ssh");
                commands.Add($"chmod 644 {sshKeyPath}/{username}/.ssh/authorized_keys");
            }

            return string.Join("\n", commands);
        }
    }


}
