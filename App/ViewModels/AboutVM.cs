using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tokio.ViewModels;

namespace DISM.ViewModels {
    class AboutVM : WorkspaceViewModel {
        public override bool? ShowDialogView(string viewName) {
            throw new NotImplementedException();
        }

        public override Window ShowView(string viewName) {
            throw new NotImplementedException();
        }
    }
}
