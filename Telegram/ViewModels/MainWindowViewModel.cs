using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Commands.MainWindowCommands;

namespace Telegram.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ExitToApp ExitToApp => new ExitToApp();
    }
}
