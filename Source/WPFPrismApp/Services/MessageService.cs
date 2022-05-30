using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BAMTS.Internal
{
    public class MessageService : IMessageService
    {
        public MessageBoxResult Show(string message, string caption = "", MessageBoxButton messageBoxButton = MessageBoxButton.OK, MessageBoxImage messageBoxImage = MessageBoxImage.None, MessageBoxResult defaultResult = MessageBoxResult.OK)
        {
            return MessageBox.Show(message, caption, messageBoxButton, messageBoxImage, defaultResult);
        }
    }
}
