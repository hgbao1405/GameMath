using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GameMathWinform.tools
{
    public static class FilePermission
    {
        public static void SetFolderPermissions(string folderPath)
        {
            DirectoryInfo dInfo = new DirectoryInfo(folderPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();

            dSecurity.AddAccessRule(new FileSystemAccessRule(
                new SecurityIdentifier(WellKnownSidType.WorldSid, null),
                FileSystemRights.FullControl,
                InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                PropagationFlags.NoPropagateInherit,
                AccessControlType.Allow));

            dInfo.SetAccessControl(dSecurity);
        }
    }
}
