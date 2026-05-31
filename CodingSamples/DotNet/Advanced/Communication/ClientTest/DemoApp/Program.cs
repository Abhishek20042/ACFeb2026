using DemoApp.Models;
using DemoApp.Views;

IDataAccessLayer store = new NetItemStore(args[0]);
var ui = new PresentationLayer(store);
ui.Render();
