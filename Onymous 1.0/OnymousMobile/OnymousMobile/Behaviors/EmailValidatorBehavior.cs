using OnymousMobile.ViewModels;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace OnymousMobile.Behaviors
{
    public class EmailValidatorBehavior : Behavior<Entry>
    {
        const string emailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.TextChanged += TextChanged;
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            var email = e.NewTextValue;

            var entry = sender as Entry;

            var vm = entry?.BindingContext as CreateAccountViewModel;

            vm.CommandEmailValidator.Execute(Regex.IsMatch(email, emailRegex));
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.TextChanged -= TextChanged;
        }
    }
}
