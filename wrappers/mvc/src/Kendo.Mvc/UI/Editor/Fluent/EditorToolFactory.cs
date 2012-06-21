namespace Kendo.Mvc.UI.Fluent
{
    using System;
    using System.Collections.Generic;

    public class EditorToolFactory : IHideObjectMembers
    {
        private readonly EditorToolGroup group;

        public EditorToolFactory(EditorToolGroup group)
        {
            this.group = group;
        }

        /*TODO :Custom tools
        public EditorToolFactory Custom(Action<EditorCustomToolBuilder> configurator)
        {
            var tool = new EditorCustomTool();
            configurator(new EditorCustomToolBuilder(tool));
            group.Tools.Add(tool);
            
            return this;
        }
        */

        public EditorToolFactory Clear()
        {
            group.Tools.Clear();

            return this;
        }

        public EditorToolFactory Bold()
        {
            return Button("bold");
        }

        public EditorToolFactory Italic()
        {
            return Button("italic");
        }

        public EditorToolFactory Underline()
        {
            return Button("underline");
        }

        public EditorToolFactory Strikethrough()
        {
            return Button("strikethrough");
        }

        public EditorToolFactory JustifyLeft()
        {
            return Button("justifyLeft");
        }

        public EditorToolFactory JustifyRight()
        {
            return Button("justifyRight");
        }

        public EditorToolFactory JustifyCenter()
        {
            return Button("justifyCenter");
        }

        public EditorToolFactory JustifyFull()
        {
            return Button("justifyFull");
        }

        public EditorToolFactory InsertUnorderedList()
        {
            return Button("insertUnorderedList");
        }

        public EditorToolFactory Indent()
        {
            return Button("indent");
        }

        public EditorToolFactory Outdent()
        {
            return Button("outdent");
        }

        public EditorToolFactory InsertOrderedList()
        {
            return Button("insertOrderedList");
        }
        
        public EditorToolFactory InsertImage()
        {
            return Button("insertImage");
        }

        public EditorToolFactory CreateLink()
        {
            return Button("createLink");
        }

        public EditorToolFactory Unlink()
        {
            return Button("unlink");
        }

        public EditorToolFactory FontName()
        {
            return ComboBox("fontName", null);
        }

        public EditorToolFactory FontName(Action<EditorDropDownItemBuilder> configurator)
        {
            var items = new List<DropDownListItem>();
            var builder = new EditorDropDownItemBuilder(items);

            configurator(builder);

            return ComboBox("fontName", items);
        }

        public EditorToolFactory FontSize()
        {
            return ComboBox("fontSize", null);
        }

        public EditorToolFactory FontSize(Action<EditorDropDownItemBuilder> configurator)
        {
            var items = new List<DropDownListItem>();
            var builder = new EditorDropDownItemBuilder(items);

            configurator(builder);

            return ComboBox("fontSize", items);
        }

        public EditorToolFactory FormatBlock()
        {
            return SelectBox("formatBlock", null);
        }

        public EditorToolFactory FormatBlock(Action<EditorDropDownItemBuilder> configurator)
        {
            var items = new List<DropDownListItem>();
            var builder = new EditorDropDownItemBuilder(items);

            configurator(builder);

            return SelectBox("formatBlock", items);
        }

        /* TODO: snippets
        public EditorToolFactory Snippets(Action<EditorSnippetBuilder> configurator)
        {
            var items = new List<DropDownListItem>();
            
            var builder = new EditorSnippetBuilder(items, DI.Current.Resolve<IVirtualPathProvider>());

            configurator(builder);

            return SelectBox("insertHtml", items);
        }
       
        */
        /*TODO: STYLES
        public EditorToolFactory Styles(Action<EditorDropDownItemBuilder> configurator)
        {
            var items = new List<DropDownListItem>();

            var builder = new EditorDropDownItemBuilder(items);

            configurator(builder);

            return SelectBox("style", items);
        }
        */

        public EditorToolFactory FontColor()
        {
            return ColorPicker("foreColor");
        }

        public EditorToolFactory BackColor()
        {
            return ColorPicker("backColor");
        }

        private EditorToolFactory Button(string text)
        {
            group.Tools.Add(new EditorTool(text));

            return this;
        }

        private EditorToolFactory ComboBox(string identifier, IList<DropDownListItem> items)
        {
            group.Tools.Add(new EditorListTool(identifier, items));

            return this;
        }

        private EditorToolFactory DropDown(string identifier, IList<DropDownListItem> items)
        {
            group.Tools.Add(new EditorListTool(identifier, items));

            return this;
        }

        private EditorToolFactory SelectBox(string identifier, IList<DropDownListItem> items)
        {
            group.Tools.Add(new EditorListTool(identifier, items));

            return this;
        }

        private EditorToolFactory ColorPicker(string identifier)
        {
            group.Tools.Add(new EditorTool(identifier));

            return this;
        }
    }
}