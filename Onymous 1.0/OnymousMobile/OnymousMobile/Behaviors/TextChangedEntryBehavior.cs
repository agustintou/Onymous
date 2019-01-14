using OnymousMobile.ViewModels;
using System;
using Xamarin.Forms;

namespace OnymousMobile.Behaviors
{
    public class TextChangedEntryBehavior : Behavior<Entry>
    {
        public string ParamEntry { get; set; }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.TextChanged += TextChanged;
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = sender as Entry;
            var vm = entry?.BindingContext as CreateAccountViewModel;
            vm.CommandEntryText.Execute(ParamEntry);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.TextChanged -= TextChanged;
        }
    }
}
