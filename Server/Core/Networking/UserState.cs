﻿using System.Drawing;
using System.Windows.Forms;
using xServer.Core.Helper;
using xServer.Core.ReverseProxy;
using xServer.Forms;

namespace xServer.Core.Networking
{
    public class UserState
    {
        public string Version { get; set; }
        public string OperatingSystem { get; set; }
        public string AccountType { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Id { get; set; }
        public string Username { get; set; }
        public string PCName { get; set; }
        public string DownloadDirectory { get; set; }

        public FrmRemoteDesktop FrmRdp { get; set; }
        public FrmTaskManager FrmTm { get; set; }
        public FrmFileManager FrmFm { get; set; }
        public FrmSystemInformation FrmSi { get; set; }
        public FrmRemoteShell FrmRs { get; set; }
        public FrmStartupManager FrmStm { get; set; }
        public FrmKeylogger FrmKl { get; set; }
        public FrmReverseProxy FrmProxy { get; set; }
        
        public bool IsAuthenticated { get; set; }
        public bool LastDirectorySeen { get; set; }
        public int LastQuality { get; set; }
        public int LastMonitor { get; set; }
        public Bitmap LastDesktop { get; set; }
        public UnsafeStreamCodec StreamCodec { get; set; }
        public ReverseProxyServer ProxyServer { get; set; }

        public UserState()
        {
            IsAuthenticated = false;
            LastDirectorySeen = true;
            LastQuality = -1;
            LastMonitor = -1;
        }

        public void DisposeForms()
        {
            if (FrmRdp != null)
                FrmRdp.Invoke((MethodInvoker)delegate { FrmRdp.Close(); });
            if (FrmTm != null)
                FrmTm.Invoke((MethodInvoker)delegate { FrmTm.Close(); });
            if (FrmFm != null)
                FrmFm.Invoke((MethodInvoker)delegate { FrmFm.Close(); });
            if (FrmSi != null)
                FrmSi.Invoke((MethodInvoker)delegate { FrmSi.Close(); });
            if (FrmRs != null)
                FrmRs.Invoke((MethodInvoker)delegate { FrmRs.Close(); });
            if (FrmStm != null)
                FrmStm.Invoke((MethodInvoker)delegate { FrmStm.Close(); });
            if (FrmKl != null)
                FrmKl.Invoke((MethodInvoker)delegate { FrmKl.Close(); });
            if (FrmProxy != null)
                FrmProxy.Invoke((MethodInvoker)delegate { FrmProxy.Close(); });
        }
    }
}