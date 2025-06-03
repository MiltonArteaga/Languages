# Language Application

## Overview

Inside the folder `Modularis Technical Test - Languages` you will find the original code provided.  
A new project named `Language.Message.Spanish` has been added to support the Spanish language.

## Configuration

To make the solution work correctly, you must configure the key `DirectorioMensajes` in the `Modularis.Language.exe.config` file.

Here is an example configuration:

```xml
<configuration>
    <appSettings>
        <add key="DirectorioMensajes" value="C:\Languages\" />
    </appSettings>
</configuration>
```

This setting indicates the folder where the language libraries (`.dll` files) must be placed.

- `Language.Message.dll` contains the default languages (English and French).
- `Language.Message.Spanish.dll` provides support for the Spanish language.

## How to Add a New Language

To add a new language, follow these steps:

1. **Create a new class library project.**
2. **Add a reference to `Language.Interface.dll`.**
3. **Create a public class** that implements the `Interface.IMessage` interface.
4. **Implement the following properties:**
   - `Description`: Name of the language.
   - `Message`: The message text to be displayed in that language.

After building the DLL, place it inside the directory specified by `DirectorioMensajes` in the config file.

This allows the application to dynamically load and support the new language without modifying the existing code.
