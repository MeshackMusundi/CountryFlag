## NOTE!
This library is no longer being maintained. Use the [updated](https://github.com/MeshackMusundi/CountryFlag.Wpf) version which works with .NET Core and has more and up-to-date flags.

# CountryFlag

![Flags screenshot](https://www.codeproject.com/KB/WPF/WpfCountryFlagControl/Flags.png)

CountryFlag is a WPF user control for displaying the flag of any one of the 249 countries and territories assigned with an ISO 3166-1 alpha-2 code.

## Requirements
- .NET Framework 4.6 

## Usage

Install the CountryFlag NuGet package by running the following command in the NuGet Package Manager Console,
```
Install-Package CountryFlag -Version 2.1.0
```

After installation is complete add a XAML reference to the assembly and proceed to use the control.
```xml
<Window ...
        xmlns:cf="clr-namespace:CountryFlag;assembly=CountryFlag">       
    <WrapPanel>
        <cf:CountryFlag Code="BT" Margin="5"/>
        <cf:CountryFlag Code="AF" Margin="5"/>
        <cf:CountryFlag Code="AO" Margin="5"/>
        <cf:CountryFlag Code="BB" Margin="5"/>
        <cf:CountryFlag Code="KE" Margin="5"/>
        <cf:CountryFlag Code="BR" Margin="5"/>
        <cf:CountryFlag Code="EG" Margin="5"/>
        <cf:CountryFlag Code="RS" Margin="5"/>
        <cf:CountryFlag Code="SZ" Margin="5"/>
    </WrapPanel>    
</Window>
```

You specify which flag you want the control to display by the setting the `Code` property, which you set with an ISO 3166-1 alpha-2 code.
