# Xray Test Steps CSV → DOCX
[![Open XML SDK](https://img.shields.io/nuget/v/DocumentFormat.OpenXml?label=Open%20XML%20SDK&logo=nuget)](https://www.nuget.org/packages/DocumentFormat.OpenXml/)
[![CsvHelper](https://img.shields.io/nuget/v/CsvHelper?label=CsvHelper&logo=nuget)](https://www.nuget.org/packages/CsvHelper/)

Small Windows app that converts an **Xray/Jira Test** CSV into a **Word (.docx)** file.  
Each test’s steps are rendered as a numbered list, with a simple header (tester, environment, site, etc.).

## Instructions ▶️
- Go to the 🔗[Release Page](https://github.com/AdrianRojasGomez/XrayCsv2Docx/releases/tag/v1.0.0).
- Download the version that matches your device.
- Open the file.  
- **Done!** 🚀

## Features ✨
- Import CSV exported from Xray/Jira
- Optional: fill header fields (tester, environment, site…)
- Generate a single DOCX file with numbered steps

## Tech / Dependencies 🛠️
- **CsvHelper** (CSV parsing)
- **Open XML SDK** (`DocumentFormat.OpenXml`) for DOCX generation

## Requirements 🪟
- Windows 10/11 (x64)
- .NET 8 SDK (to build) / runtime bundled if using the Release single-file build

## Quick Start (Build)
```bash
git clone https://github.com/AdrianRojasGomez/XrayCsv2Docx.git
cd XrayCsv2Docx
# open XrayCsvToDocx.sln in Visual Studio (or run:)
dotnet build

Publish (single file, self-contained) 📦

dotnet publish WinFormsApp -c Release -r win-x64 \
  -p:PublishSingleFile=true -p:PublishReadyToRun=true --self-contained true

Usage ▶️

    Run the app (WinFormsApp).

    Select your Xray/Jira CSV export.

    (Optional) Fill the header fields.

    Click Generate to produce the .docx.

    💡 Tip: Export tests from Xray/Jira in CSV with columns that include the step text you want rendered.

Project Structure

XrayCsv2Docx/
├─ WinFormsApp/   # UI (WinForms)
├─ Bussiness/     # Application logic
└─ Model/         # data models
