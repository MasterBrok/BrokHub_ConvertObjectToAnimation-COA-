
using System.Windows;
using System.Windows.Controls;

namespace BrokHub_ConverObjectToAnimation.BaseControls.CheckBoxs
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:BrokHub_ConverObjectToAnimation.BaseControls.CheckBoxs"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:BrokHub_ConverObjectToAnimation.BaseControls.CheckBoxs;assembly=BrokHub_ConverObjectToAnimation.BaseControls.CheckBoxs"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:ccCheckBox/>
    ///
    /// </summary>
    public class ccCheckBox : CheckBox
    {
        static ccCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccCheckBox), new FrameworkPropertyMetadata(typeof(ccCheckBox)));
        }
    }
}
