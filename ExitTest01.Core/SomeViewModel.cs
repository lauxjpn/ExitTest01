using MvvmCross.Core.ViewModels;

namespace ExitTest01.Core
{
    public class SomeViewModel : MvxViewModel
    {
        private int _clickCount;
        public int ClickCount
        {
            get { return _clickCount; }
            set { SetProperty(ref _clickCount, value); }
        }

        private IMvxCommand _incrementClickCountCommand;
        public IMvxCommand IncrementClickCountCommand => _incrementClickCountCommand ?? (_incrementClickCountCommand = new MvxCommand(IncrementClickCount));

        private void IncrementClickCount()
        {
            ClickCount++;
        }
    }
}