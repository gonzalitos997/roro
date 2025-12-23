# BatchProcess3 - Avalonia UI MVVM

Proyecto basado en el **Capítulo 7** de **Avalonia UI Real World** por **AngelSix**.

## 📚 Contenido

Este proyecto implementa el patrón **MVVM (Model-View-ViewModel)** utilizando Avalonia UI, siguiendo las mejores prácticas presentadas en el tutorial de AngelSix.

## 🏗️ Estructura del Proyecto

```
BatchProcess3/
├── Core/                      # Infraestructura MVVM
│   ├── ViewModelBase.cs      # Clase base para ViewModels
│   ├── RelayCommand.cs       # Implementación de ICommand
│   └── IoC.cs                # Contenedor de IoC simple
├── ViewModels/               # ViewModels de la aplicación
│   └── MainWindowViewModel.cs
├── Views/                    # Vistas (futuras páginas)
├── Models/                   # Modelos de datos
├── MainWindow.axaml         # Ventana principal
├── MainWindow.axaml.cs      # Code-behind de ventana principal
├── App.axaml                # Configuración de aplicación
└── App.axaml.cs             # Inicialización y setup IoC
```

## 🎯 Características Implementadas

### Capítulo 7 - MVVM Pattern

✅ **ViewModelBase**
- Implementación de `INotifyPropertyChanged`
- Método `SetProperty` para actualización automática de UI
- Base para todos los ViewModels

✅ **RelayCommand**
- Implementación completa de `ICommand`
- Soporte para `CanExecute`
- Manejo de eventos

✅ **IoC Container**
- Contenedor simple de dependencias
- Registro y resolución de servicios
- Configuración centralizada en `App.xaml.cs`

✅ **MainWindowViewModel**
- Propiedades con binding bidireccional
- Comandos para interacción de usuario
- Lógica de negocio separada de la vista

✅ **Data Binding**
- Binding a propiedades del ViewModel
- Binding a comandos
- Design-time DataContext

## 🚀 Cómo Ejecutar

```bash
# Compilar el proyecto
dotnet build

# Ejecutar la aplicación
dotnet run
```

## 📖 Aprendizajes del Capítulo 7

1. **Separación de Responsabilidades**: La vista (XAML) solo se encarga de la presentación
2. **Data Binding**: Conexión reactiva entre vista y ViewModel
3. **Commands**: Manejo de acciones de usuario sin código en code-behind
4. **INotifyPropertyChanged**: Notificación automática de cambios a la UI
5. **IoC/DI**: Inversión de control para gestión de dependencias

## 🛠️ Tecnologías

- **.NET 9.0**
- **Avalonia UI 11.3.6**
- **C# 12**

## 👨‍💻 Autor

Implementado siguiendo el tutorial de **AngelSix - Avalonia UI Real World**

## 📝 Licencia

Este proyecto es de propósito educativo.
