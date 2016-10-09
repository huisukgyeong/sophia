using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.ViewModels
{
    public class GoalSetupViewModel : MvxViewModel
    {
        public MvxCommand MenuViewCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<MenuViewModel>());
            }
        }
    }
}
