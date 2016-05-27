// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the PetHouseView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Ninja.iOS.Views
{
    using Core.ViewModels;
    using MvvmCross.Binding.BindingContext;
    using UIKit;

    /// <summary>
    /// Defines the PetHouseView type.
    /// </summary>
    public partial class PetHouseView : BaseView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PetHouseView"/> class.
        /// </summary>
        public PetHouseView() 
            : base("PetHouseView", null)
        {
        }

        /// <summary>
        /// Views the did load.
        /// </summary>
        /// <summary>
        /// Called when the View is first loaded
        /// </summary>
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            MvxFluentBindingDescriptionSet<PetHouseView, PetHouseViewModel> set = this.CreateBindingSet<PetHouseView, PetHouseViewModel>();
            set.Bind(this.UiLabel).To(vm => vm.MyProperty);
            set.Bind(this.UiTextField).To(vm => vm.MyProperty);
            set.Apply();

            UITapGestureRecognizer tap = new UITapGestureRecognizer(() => this.View.ResignFirstResponder());
            this.View.AddGestureRecognizer(tap);
        }
    }
}
