using OnymousMobile.ViewModels;
using System;
using Xamarin.Forms;

namespace OnymousMobile.Behaviors
{
    public class FocusEntryBehaviors : Behavior<Entry>
    {
        public string ParamEntry { get; set; }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.Focused += FocusEntry;
            bindable.Unfocused += UnFocusEntry;
        }

        private void UnFocusEntry(object sender, FocusEventArgs e)
        {
            var entry = sender as Entry;
            var vm = entry?.BindingContext as CreateAccountViewModel;
            vm.CommandEntryUnFocus.Execute(ParamEntry);
        }

        private void FocusEntry(object sender, FocusEventArgs e)
        {
            var entry = sender as Entry;
            var vm = entry?.BindingContext as CreateAccountViewModel;
            vm.CommandEntryFocus.Execute(ParamEntry);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.Focused -= FocusEntry;
            bindable.Unfocused -= UnFocusEntry;
        }
    }
}
