namespace ToolsQA.Tests.Ui.Pages.PageNavigator.LeftPanel.Widgets
{
    using ToolsQA.Tests.Ui.Pages.Pages.Widgets;

    public class WidgetsSection : BaseSection
    {
        public AccordianPage Accordian() => Navigate<AccordianPage>("accordian");

        public AutoCompletePage AutoComplete() => Navigate<AutoCompletePage>("auto-complete");

        public DatePickerPage DatePicker() => Navigate<DatePickerPage>("date-picker");

        public SliderPage Slider() => Navigate<SliderPage>("slider");

        public ProgressBarPage ProgressBar() => Navigate<ProgressBarPage>("progress-bar");

        public TabsPage Tabs() => Navigate<TabsPage>("tabs");

        public ToolTipsPage ToolTips() => Navigate<ToolTipsPage>("tool-tips");

        public MenuPage Menu() => Navigate<MenuPage>("menu");

        public SelectMenuPage SelectMenu() => Navigate<SelectMenuPage>("select-menu");
    }
}
