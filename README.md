# BatchProcess3 - Avalonia UI MVVM

Proyecto basado en el **Capítulo 7** de **Avalonia UI Real World** por **AngelSix**.

## 📚 Contenido

Este proyecto implementa el patrón **MVVM (Model-View-ViewModel)** y **Control Themes** utilizando Avalonia UI, siguiendo las mejores prácticas presentadas en el tutorial de AngelSix.

## 🏗️ Estructura del Proyecto

```
BatchProcess3/
├── Core/                      # Infraestructura MVVM
│   ├── ViewModelBase.cs      # Clase base para ViewModels
│   ├── RelayCommand.cs       # Implementación de ICommand
│   ├── IoC.cs                # Contenedor de IoC simple
│   ├── ThemeMode.cs          # Enum de modos de tema
│   └── ThemeManager.cs       # Gestor de cambio de temas
├── Themes/                   # Temas y estilos personalizados
│   ├── Colors.axaml          # Paleta de colores (Light/Dark)
│   ├── Buttons.axaml         # Estilos de botones
│   └── TextBlocks.axaml      # Estilos de textos
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

### Capítulo 7 - Control Themes

✅ **Sistema de Temas Dinámico**
- Tema Claro (Light) y Oscuro (Dark)
- Cambio de tema en tiempo real
- ThemeManager para gestión centralizada

✅ **Paleta de Colores Personalizada**
- Colores primarios y secundarios
- Colores de superficie y fondo
- Colores de texto y bordes
- Sistema de colores dinámicos con `DynamicResource`

✅ **Estilos de Botones Personalizados**
- BaseButton: Botón primario con animaciones
- SecondaryButton: Botón secundario con borde
- DangerButton: Botón de acción destructiva
- Estados hover, pressed y disabled
- Transiciones suaves

✅ **Estilos de Texto**
- Title, Subtitle, Heading
- Body y Caption
- Counter (display especial)
- Adaptación automática al tema activo

✅ **Interfaz Moderna**
- Diseño con Border y CornerRadius
- Espaciado consistente
- Tipografía clara y jerárquica
- Experiencia de usuario fluida

## 🚀 Cómo Ejecutar

```bash
# Compilar el proyecto
dotnet build

# Ejecutar la aplicación
dotnet run
```

## 🎨 Características de la Aplicación

- **Contador Interactivo**: Incrementa y resetea el contador
- **Cambio de Tema**: Alterna entre tema claro y oscuro con un botón
- **Estilos Personalizados**: Todos los controles usan estilos custom
- **Animaciones Suaves**: Transiciones en botones y cambios de tema
- **Diseño Responsive**: Interfaz adaptable y moderna

## 📖 Aprendizajes del Capítulo 7

### MVVM Pattern
1. **Separación de Responsabilidades**: La vista (XAML) solo se encarga de la presentación
2. **Data Binding**: Conexión reactiva entre vista y ViewModel
3. **Commands**: Manejo de acciones de usuario sin código en code-behind
4. **INotifyPropertyChanged**: Notificación automática de cambios a la UI
5. **IoC/DI**: Inversión de control para gestión de dependencias

### Control Themes
1. **ResourceDictionary**: Organización de recursos compartidos
2. **DynamicResource**: Referencias dinámicas que cambian en runtime
3. **Styles y Selectors**: Aplicación de estilos a controles específicos
4. **Theme Management**: Sistema centralizado de gestión de temas
5. **Visual States**: Manejo de estados hover, pressed, disabled
6. **Transitions**: Animaciones fluidas entre estados

## 🛠️ Tecnologías

- **.NET 9.0**
- **Avalonia UI 11.3.6**
- **C# 12**
- **MVVM Pattern**
- **Custom Control Themes**

## 👨‍💻 Autor

Implementado siguiendo el tutorial de **AngelSix - Avalonia UI Real World**

## 📝 Licencia

Este proyecto es de propósito educativo.
