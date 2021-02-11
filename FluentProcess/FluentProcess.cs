using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Security;
using System.Text;

namespace FluentProcessBuilder
{
    public class FluentProcess : Process
    {
        public new FluentProcess BeginErrorReadLine()
        {
            base.BeginErrorReadLine();
            return this;
        }
        
        public new FluentProcess BeginOutputReadLine()
        {
            base.BeginOutputReadLine();
            return this;
        }

        public new FluentProcess WaitForExit()
        {
            base.WaitForExit();
            return this;
        }

        public new FluentProcess Start()
        {
            base.Start();
            return this;
        }

        public new FluentProcess OutputDataReceived(DataReceivedEventHandler handler)
        {
            base.OutputDataReceived += handler;
            return this;
        }
        
        public new FluentProcess ErrorDataReceived(DataReceivedEventHandler handler)
        {
            base.ErrorDataReceived += handler;
            return this;
        }
        
        public FluentProcess PriorityClass(ProcessPriorityClass priorityClass = default)
        {
            base.PriorityClass = priorityClass == default ? ProcessPriorityClass.Normal : priorityClass;
            return this;
        }
        
        public FluentProcess ProcessorAffinity(IntPtr ptr)
        {
            base.ProcessorAffinity = ptr;
            return this;
        }
        
        public FluentProcess SynchronizingObject(ISynchronizeInvoke invoke)
        {
            base.SynchronizingObject = invoke;
            return this;
        }
        
        public FluentProcess Site(ISite site)
        {
            base.Site = site;
            return this;
        }
        
        public FluentProcess PriorityBoostEnabled(bool enabled = true)
        {
            base.PriorityBoostEnabled = enabled;
            return this;
        }

        public FluentProcess EnableRaisingEvents(bool enabled = true)
        {
            base.EnableRaisingEvents = enabled;
            return this;
        }
        
        public FluentProcess MaxWorkingSet(IntPtr ptr)
        {
            base.MaxWorkingSet = ptr;
            return this;
        }
        
        public FluentProcess MinWorkingSet(IntPtr ptr)
        {
            base.MinWorkingSet = ptr;
            return this;
        }
        
        public FluentProcess FileName(string filename)
        {
            StartInfo.FileName = filename;
            return this;
        }
        
        public FluentProcess ArgumentList(params string[] args)
        {
            foreach (var s in args)
            {
                StartInfo.ArgumentList.Add(s);
            }
            return this;
        }
        
        public FluentProcess Arguments(string args)
        {
            StartInfo.Arguments = args;
            return this;
        }
        
        public FluentProcess CreateNoWindow(bool enabled = true)
        {
            StartInfo.CreateNoWindow = enabled;
            return this;
        }
        
        public FluentProcess Domain(string domain)
        {
            StartInfo.Domain = domain;
            return this;
        }
        
        public FluentProcess Environment(params KeyValuePair<string,string>[] vars)
        {
            foreach (var v in vars)
            {
                StartInfo.Environment.Add(v);
            }
            return this;
        }
        
        public FluentProcess EnvironmentVariables(params KeyValuePair<string,string>[] vars)
        {
            foreach (var v in vars)
            {
                StartInfo.EnvironmentVariables.Add(v.Key, v.Value);   
            }
            return this;
        }
        
        public FluentProcess ErrorDialog(bool enabled = true)
        {
            StartInfo.ErrorDialog = enabled;
            return this;
        }
        
        public FluentProcess ErrorDialogHandle(IntPtr ptr)
        {
            StartInfo.ErrorDialogParentHandle = ptr;
            return this;
        }
        
        public FluentProcess LoadUserProfile(bool enabled = true)
        {
            StartInfo.LoadUserProfile = enabled;
            return this;
        }
        
        public FluentProcess Password(SecureString password)
        {
            StartInfo.Password = password;
            return this;
        }
        
        public FluentProcess PasswordInClearText(string password)
        {
            StartInfo.PasswordInClearText = password;
            return this;
        }
        
        public FluentProcess RedirectStandardError(bool enabled = true)
        {
            StartInfo.RedirectStandardError = enabled;
            return this;
        }
        
        public FluentProcess RedirectStandardInput(bool enabled = true)
        {
            StartInfo.RedirectStandardInput = enabled;
            return this;
        }
        
        public FluentProcess RedirectStandardOutput(bool enabled = true)
        {
            StartInfo.RedirectStandardOutput = enabled;
            return this;
        }
        
        public FluentProcess StandardErrorEncoding(Encoding encoding = null)
        {
            StartInfo.StandardErrorEncoding = encoding ?? Encoding.Default;
            return this;
        }
        
        public FluentProcess StandardInputEncoding(Encoding encoding = null)
        {
            StartInfo.StandardInputEncoding = encoding ?? Encoding.Default;
            return this;
        }
        
        public FluentProcess StandardOutputEncoding(Encoding encoding = null)
        {
            StartInfo.StandardOutputEncoding = encoding ?? Encoding.Default;
            return this;
        }
        
        public FluentProcess Username(string username)
        {
            StartInfo.UserName = username;
            return this;
        }
        
        public FluentProcess UseShellExecute(bool enabled = true)
        {
            StartInfo.UseShellExecute = enabled;
            return this;
        }
        
        public FluentProcess Verb(string verb)
        {
            StartInfo.Verb = verb;
            return this;
        }
        
        public FluentProcess WindowStyle(ProcessWindowStyle style = default)
        {
            StartInfo.WindowStyle = style == default ? ProcessWindowStyle.Normal : style;
            return this;
        }
        
        public FluentProcess WorkingDirectory(string directory)
        {
            StartInfo.WorkingDirectory = directory;
            return this;
        }
    }
}