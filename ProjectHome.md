This is a very small implementation of a Flash ActiveX control hosted in a WPF application which uses MVVM pattern. It demonstrates such techniques as
- Binding a WPF view to a viewmodel
- Decoupling the UI (view) from the application logic (viewmodel)
- Usage of EventAggregator
- Usage of extension methods
- Usage of IModule interface to load and register all classes required by the application
- Hosting a Windows Forms control in a WPF application using a WindowsFormsHost