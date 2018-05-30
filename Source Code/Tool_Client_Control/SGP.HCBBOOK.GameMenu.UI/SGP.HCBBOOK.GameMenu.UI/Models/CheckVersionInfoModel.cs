using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.HCBBOOK.GameMenu.UI.Models
{
    public class CheckVersionInfoModel
    {
        //Code
        public int ID { get; set; }
        //
        // Summary:
        //     If new update is available then returns true otherwise false.
        public bool IsUpdateAvailable { get; set; }
        //
        // Summary:
        //     Download URL of the update file.
        public string DownloadURL { get; set; }
        //
        // Summary:
        //     URL of the webpage specifying changes in the new update.
        public string ChangelogURL { get; set; }
        //
        // Summary:
        //     Returns newest version of the application available to download.
        public Version CurrentVersion { get; set; }
        //
        // Summary:
        //     Returns version of the application currently installed on the user's PC.
        public Version InstalledVersion { get; set; }
        //
        // Summary:
        //     Shows if the update is required or optional.
        public bool Mandatory { get; set; }
        //
        // Summary:
        //     Command line arguments used by Installer.
        public string InstallerArgs { get; set; }
        /// <summary>
        // Version number
        /// </summary>
        public string Version { get; set; }
        //
        // Summary:
        //     Checksum of the update file.
        public string Checksum { get; set; }
        /// <summary>
        /// Soft name
        /// </summary>
        public string Softname { get; set; }
        /// <summary>
        /// Change logs
        /// </summary>
        public string ChangeLogs { get; set; }
        /// <summary>
        /// Date changelog
        /// </summary>
        public DateTime? DateChange { get; set; }
        //
        // Summary:
        //     Hash algorithm that generated the checksum provided in the XML file.
        public string HashingAlgorithm { get; set; }
    }
}
