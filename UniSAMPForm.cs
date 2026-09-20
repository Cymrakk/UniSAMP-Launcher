using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace universal_samp_launcher
{
    public partial class UniSAMPForm : Form
    {
    	private string gtaPath = AppDomain.CurrentDomain.BaseDirectory;
    	private string launcherPath;
    	private string versionsPath;
    	private string cfgPath;
    	
    	// Флаг, который предотвращает сохранение файла во время его чтения при запуске
    	private bool isLoadingConfig = false;
    	
        public UniSAMPForm()
        {
            // Этот метод обязателен, он строит кнопки на экране. Не удаляйте его!
            InitializeComponent();
            
            launcherPath = Path.Combine(gtaPath, "UniSAMP");
            versionsPath = Path.Combine(launcherPath, "versions");
            cfgPath = Path.Combine(launcherPath, "config.ini");
        }
        
		void UniSAMPFormLoad(object sender, EventArgs e)
		{
			try
			{
				// Ограничиваем длину ника в поле ввода (максимум 24 символа, как в SA-MP)
				NickNameTB.MaxLength = 24;
				
				// Подключаем автоматическое сохранение к текстовым полям
				NickNameTB.TextChanged += SaveConfig;
				IPServerTB.TextChanged += SaveConfig;

				// Проверяем, существует ли папка UniSAMP, если нет — создаем
				if (!Directory.Exists(launcherPath))
				{
					Directory.CreateDirectory(launcherPath);
				}
				
				// Если файла конфигурации нет, создаем его по умолчанию
				if (!File.Exists(cfgPath))
				{
					string[] defaultCfg = new string[] {
						"// This is Config file for UniSAMP",
						"NickName = Your_Name",
						"ServerIP = 127.0.0.1:7777",
						"// END"
					};
					File.WriteAllLines(cfgPath, defaultCfg);
				}

				// Включаем режим загрузки, чтобы не триггерить сохранение в файл при заполнении полей
				isLoadingConfig = true;

				// Читаем строки из config.ini
				string[] lines = File.ReadAllLines(cfgPath);
				
				foreach (string line in lines)
				{
					string trimmedLine = line.Trim();
					
					if (string.IsNullOrEmpty(trimmedLine) || trimmedLine.StartsWith("//"))
					{
						continue;
					}
					
					int separatorIndex = trimmedLine.IndexOf('=');
					if (separatorIndex > 0)
					{
						string key = trimmedLine.Substring(0, separatorIndex).Trim();
						string value = trimmedLine.Substring(separatorIndex + 1).Trim();
						
						if (key.Equals("NickName", StringComparison.OrdinalIgnoreCase))
						{
							// Если ник в файле вдруг длиннее 24 символов, обрезаем его
							if (value.Length > 24) value = value.Substring(0, 24);
							NickNameTB.Text = value;
						}
						else if (key.Equals("ServerIP", StringComparison.OrdinalIgnoreCase))
						{
							IPServerTB.Text = value;
						}
					}
				}
				
				// Выключаем режим загрузки
				isLoadingConfig = false;
			}
			catch (Exception ex)
			{
				isLoadingConfig = false;
				MessageBox.Show("Ошибка при работе с файлом конфигурации: " + ex.Message, "Ошибка");
			}
		}
		
		// Метод для автоматического сохранения изменений в config.ini
		private void SaveConfig(object sender, EventArgs e)
		{
			// Если программа сейчас просто считывает файл при старте — ничего не перезаписываем
			if (isLoadingConfig) return;
			
			try
			{
				string[] updatedCfg = new string[] {
					"// This is Config file for UniSAMP",
					"NickName = " + NickNameTB.Text.Trim(),
					"ServerIP = " + IPServerTB.Text.Trim(),
					"// END"
				};
				
				File.WriteAllLines(cfgPath, updatedCfg);
			}
			catch (Exception ex)
			{
				// Ловим ошибки, если файл заблокирован другой программой
				Debug.WriteLine("Ошибка сохранения конфига: " + ex.Message);
			}
		}

		private void Button_githubClick(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("https://github.com");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error", "error");
			}
		}
		
		void Button_siteClick(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("https://github.com");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error", "error");
			}
		}
    }
}
