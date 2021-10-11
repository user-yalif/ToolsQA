namespace ToolsQA.Tests.Ui.Pages.PageNavigator.LeftPanel.Interactions
{
    using ToolsQA.Tests.Ui.Pages.Pages.Interactions;

    public class InteractionsSection : BaseSection
    {
        public SortablePage Sortable() => Navigate<SortablePage>("sortable");

        public SelectablePage Selectable() => Navigate<SelectablePage>("selectable");

        public ResizablePage Resizable() => Navigate<ResizablePage>("resizable");

        public DroppablePage Droppable() => Navigate<DroppablePage>("droppable");

        public DragablePage Dragable() => Navigate<DragablePage>("dragabble");
    }
}
