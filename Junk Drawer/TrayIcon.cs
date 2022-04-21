using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junk_Drawer
{
    class TrayIcon
    {
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private Form1 form1;

        public void initializeTrayIcon(Form1 form1)
        {
            this.form1 = form1;
            trayIcon = new NotifyIcon();
            trayIcon.Text = "Junk Drawer";
            Icon icon = new Icon("MS Word.ico");
            trayIcon.Icon = icon;

            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Toggle GUI", contextToggleGUI_Click);

            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
        }

        public void diposeAll()
        {
            trayIcon.Visible = false;
            trayIcon.Icon = null;
            trayIcon.Dispose();
            trayIcon = null;

            trayMenu.Dispose();
            form1.Dispose();
        }

        private void contextToggleGUI_Click(object sender, EventArgs e)
        {
            form1.initializeNoteListFromXML();
        }
    }
}