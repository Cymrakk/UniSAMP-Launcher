using System;
using System.Windows.Forms;

// Изменили namespace на universal_samp_launcher, как в UniSAMPForm.cs
namespace universal_samp_launcher 
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			// Заменяем MainForm на UniSAMPForm, которая у вас написана
			Application.Run(new UniSAMPForm()); 
		}
	}
}
