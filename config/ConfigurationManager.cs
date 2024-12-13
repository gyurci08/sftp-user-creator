using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sftp_user_creator.config
{
    public interface IConfigurationService
    {
        Task<IDictionary<string, string>> LoadConfigurationAsync();
        Task SaveConfigurationAsync(IDictionary<string, string> configuration);
    }

    public class FileConfigurationService : IConfigurationService
    {
        private readonly string _configPath;
        private const string DefaultConfig = """
                                                group=
                                                home=
                                                public_keys_dir=
                                                """;

        public FileConfigurationService(string configPath)
        {
            _configPath = configPath;
        }

        public async Task<IDictionary<string, string>> LoadConfigurationAsync()
        {
            string configContent;
            try
            {
                configContent = await File.ReadAllTextAsync(_configPath);
            }
            catch (FileNotFoundException)
            {
                await File.WriteAllTextAsync(_configPath, DefaultConfig);
                configContent = DefaultConfig;
            }

            return ParseConfigContent(configContent);
        }

        public async Task SaveConfigurationAsync(IDictionary<string, string> configuration)
        {
            var content = string.Join(Environment.NewLine, configuration.Select(kvp => $"{kvp.Key}={kvp.Value}"));
            await File.WriteAllTextAsync(_configPath, content);
        }

        private static IDictionary<string, string> ParseConfigContent(string content)
        {
            return content.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(line => line.Split('=', 2))
                .Where(parts => parts.Length == 2)
                .ToDictionary(parts => parts[0].Trim(), parts => parts[1].Trim());
        }
    }


}
