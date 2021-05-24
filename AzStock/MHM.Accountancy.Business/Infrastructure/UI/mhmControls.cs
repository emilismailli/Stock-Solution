using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace MHM.Accountancy.Business.Infrastructure.UI
{
    public class GlobalActions
    {
        static public readonly ButtonPressedEventHandler buttonClick = (object sender, ButtonPressedEventArgs e) =>
        {
            var control = (PopupBaseEdit)sender;
            switch (e.Button.Kind)
            {
                case ButtonPredefines.Delete:
                    control.EditValue = null;
                    break;
                default:
                    break;
            }
        };
    }

    public class erpLookUpEdit : LookUpEdit
    {
        public erpLookUpEdit()
            : base()
        {
            this.Properties.NullText = "[Seçim edilməyib]";
            this.ButtonClick += GlobalActions.buttonClick;
            this.Properties.Buttons.AddRange(new EditorButton[] {
            new EditorButton(ButtonPredefines.Combo),
            new EditorButton(ButtonPredefines.Delete)});
        }
    }

    public class erpTreeListLookUpEdit : TreeListLookUpEdit
    {
        public erpTreeListLookUpEdit()
       : base()
        {
            this.Properties.NullText = "[Seçim edilməyib]";
            this.Properties.TreeList.KeyFieldName = "Id";
            this.Properties.TreeList.ParentFieldName = "ParentId";
            this.ButtonClick += GlobalActions.buttonClick;
            this.Properties.Buttons.AddRange(new EditorButton[] {
            new EditorButton(ButtonPredefines.Combo),
            new EditorButton(ButtonPredefines.Delete)});
        }
    }

    public class erpGridLookUpEdit : GridLookUpEdit
    {
        public erpGridLookUpEdit()
       : base()
        {
            this.Properties.NullText = "[Seçim edilməyib]";
            this.ButtonClick += GlobalActions.buttonClick;
            this.Properties.Buttons.AddRange(new EditorButton[] {
            new EditorButton(ButtonPredefines.Combo),
            new EditorButton(ButtonPredefines.Delete)});
        }
    }

    public class erpSearchLookUpEdit : SearchLookUpEdit
    {
        public erpSearchLookUpEdit()
       : base()
        {
            this.Properties.NullText = "[Seçim edilməyib]";
            this.ButtonClick += GlobalActions.buttonClick;
            this.Properties.Buttons.AddRange(new EditorButton[] {
            new EditorButton(ButtonPredefines.Combo),
            new EditorButton(ButtonPredefines.Delete)});
        }
    }

    public class erpDateEdit : DateEdit
    {
        public erpDateEdit()
       : base()
        {
            this.Properties.NullText = "[Seçim edilməyib]";
            this.ButtonClick += GlobalActions.buttonClick;
            this.Properties.Buttons.AddRange(new EditorButton[] {
            new EditorButton(ButtonPredefines.Combo),
            new EditorButton(ButtonPredefines.Delete)});
        }
    }

    public class erpMemoExEdit : MemoExEdit
    {
        public erpMemoExEdit()
       : base()
        {
            this.Properties.NullText = null;
            this.EditValue = null;
            this.Text = "";
            this.ButtonClick += GlobalActions.buttonClick;
            this.Properties.Buttons.AddRange(new EditorButton[] {
            new EditorButton(ButtonPredefines.Combo),
            new EditorButton(ButtonPredefines.Delete)});
        }
    }

    public class erpCalcEdit : CalcEdit
    {
        public erpCalcEdit()
       : base()
        {
            this.ButtonClick += (object sender, ButtonPressedEventArgs e) =>
            {
                var control = (PopupBaseEdit)sender;
                switch (e.Button.Kind)
                {
                    case ButtonPredefines.Delete:
                        control.Text = null;
                        break;
                    default:
                        break;
                }
            }; ;
            this.Properties.Buttons.AddRange(new EditorButton[] {
            new EditorButton(ButtonPredefines.Combo),
            new EditorButton(ButtonPredefines.Delete)});
        }
    }
}
