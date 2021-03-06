﻿using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Plugins.PhoneCall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YWWAC.core.Models;

namespace YWWAC.core.ViewModels
{
    public class ConsultantViewModel : MvxViewModel
    {
        private Consultant selectedConsultant;
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                SetProperty(ref name, value);
            }
        }
        private string profession;
        public string Profession
        {
            get { return profession; }
            set
            {
                SetProperty(ref profession, value);
            }
        }
        private string contact;
        public string Contact
        {
            get { return contact; }
            set
            {
                SetProperty(ref contact, value);
            }
        }
        private string institution;
        public string Institution
        {
            get { return institution; }
            set
            {
                SetProperty(ref institution, value);
            }
        }
        public ICommand CallGeneralCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    PluginLoader.Instance.EnsureLoaded();
                    Mvx.Resolve<IMvxPhoneCallTask>().MakePhoneCall("Contact us", selectedConsultant.Contact);
                });
            }
        }
        public void Init(Consultant parameters)
        {
            selectedConsultant = parameters;
        }
        public override void Start()
        {
            base.Start();
            Name = selectedConsultant.Name;
            Profession = selectedConsultant.Profession;
            Contact = selectedConsultant.Contact;
            Institution = selectedConsultant.Institution;
        }
    }
}
