using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.ViewModels
{
    public class ConsultationViewModel : MvxViewModel
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                SetProperty(ref name, value);
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
    }
}
