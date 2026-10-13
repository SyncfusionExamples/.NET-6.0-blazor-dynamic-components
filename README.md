# Using Dynamic Components to Render Syncfusion Blazor Components in a .NET 6 Blazor Application

## Overview

This sample demonstrates how Syncfusion Blazor components can be rendered dynamically at runtime by using the DynamicComponent capability introduced in .NET 6. Rather than hard-coding component instances in Razor markup, the application selects and renders components dynamically based on application logic and metadata.

The approach is useful when building configurable user interfaces, component dashboards, form builders, or runtime-driven experiences where component types are determined dynamically. The sample illustrates how Blazor component references and runtime rendering can be combined to create flexible UI architectures.

## Key Features

- Uses the .NET 6 `DynamicComponent` feature to render Razor components dynamically at runtime.
- Provides component selection through the Syncfusion Blazor `SfDropDownList` component using the `DataSource` and `@bind-Value` properties.
- Resolves component types dynamically with `Type.GetType()` using assembly-qualified component names.
- Passes component parameters dynamically through `Dictionary<string, object>` collections.
- Dynamically loads the `MeetingSchedules` component and supplies data through the `ScheduleData` parameter.
- Dynamically loads the `SalesPersonDetails` component and supplies data through the `Employees` parameter.
- Uses the Syncfusion Blazor Scheduler component (`SfSchedule`) to display appointment data in Agenda view.
- Configures the Scheduler using:
  - `TValue="MeetingSchedule"`
  - `SelectedDate`
  - `CurrentView="View.Agenda"`
  - `ScheduleEventSettings.DataSource`
  - `Height`
- Uses the Syncfusion Blazor DataGrid component (`SfGrid`) to display employee information.
- Defines Grid columns using multiple `GridColumn` elements bound with the `Field` property.
- Displays employee details including Name, Title, City, Postal Code, and Phone.
- Uses strongly typed model classes:
  - `MeetingSchedule`
  - `Salesperson`
- Generates Scheduler appointment data through the `MeetingSchedule.GetMeetingData()` method.
- Generates employee records through the `Salesperson.GetSalesperson()` method.
- Initializes dynamic component configuration during the `OnInitialized()` lifecycle method.
- Demonstrates runtime UI composition by combining Blazor Dynamic Components with Syncfusion UI components.

## Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet) compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download the repository.
2. Open `BlazorDynamic.sln`.
3. Restore NuGet packages.
4. Build the solution.
5. Set the startup project if prompted.
6. Run the application using `Ctrl+F5`.

**Visual Studio Code**

1. Open the repository folder.
2. Navigate to the project directory.

```bash
dotnet restore
dotnet run
```

3. Open the application using the URL displayed in the console.

## Project Structure

`Pages/Index.razor` - Main page that hosts the component selector, configures dynamic component mappings, initializes sample data, and renders components using `DynamicComponent`.

`DynamicComponents/MeetingSchedules.razor` - Dynamic Scheduler component that receives appointment data through the `ScheduleData` parameter and renders it using the Syncfusion `SfSchedule` component.

`DynamicComponents/SalesPersonDetails.razor` - Dynamic Grid component that receives employee data through the `Employees` parameter and displays it using the Syncfusion `SfGrid` component.

`Models/MeetingSchedule.cs` - Scheduler appointment model containing meeting properties such as `Id`, `Subject`, `StartTime`, `EndTime`, and `EID`, along with the `GetMeetingData()` sample data generator.

`Models/Salesperson.cs` - Employee data model containing salesperson information such as employee ID, name, title, address, phone, and email, along with the `GetSalesperson()` sample data generator.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- **Watch the webinar recording here**: https://www.youtube.com/watch?v=97iORc6wjlE
- **Reference blog**: https://www.syncfusion.com/blogs/post/how-to-dynamically-render-a-component-in-a-blazor-application
- **Reference real-time example**: https://github.com/SyncfusionExamples/Dynamically-Render-a-Component-in-Blazor-Application

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.