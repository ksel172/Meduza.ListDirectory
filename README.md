# Meduza.ListDirectory

`Meduza.ListDirectory` is an example implementation of a module for Meduza using the `Meduza.Agent.ModuleBase`.

---

## How To Package

To package your module for release, follow these steps:

1. **Compile your project** to generate the main DLL file (`ListDirectory.dll` in this case).
2. **Create a JSON metadata file** (`ListDirectory.json`) to describe the module, its usage, and the available commands.
3. **Package the following files into a ZIP file**:
   - The main DLL (`ListDirectory.dll`).
   - The JSON metadata file (`ListDirectory.json`).
   - **Meduza.Agent.ModuleBase.dll** (mandatory dependency).
   - Any other necessary `.dll` dependencies.

The **ZIP file** should have the following structure:
```
ListDirectory.zip
├── ListDirectory.dll               (Your compiled module)
├── ListDirectory.json              (Module metadata)
├── Meduza.Agent.ModuleBase.dll     (Mandatory dependency)
└── <other dependencies>.dll        (Additional required dependencies)
```

The **zip file** should be named the same as the module (e.g., `ListDirectory.zip`).

---

## Contributing
Any contributions are welcome! If you encounter issues or have ideas for improvement, feel free to submit a pull request or open an issue on the [GitHub repository](https://github.com/ksel172/Meduza.Agent.ModuleBase).

---

## License
This package is licensed under the [MIT License](LICENSE).