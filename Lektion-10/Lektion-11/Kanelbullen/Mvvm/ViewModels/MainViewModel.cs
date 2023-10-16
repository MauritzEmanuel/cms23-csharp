using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kanelbullen.Mvvm.Models;
using Kanelbullen.Mvvm.NewFolder;
using Kanelbullen.Mvvm.Views;
using System.Collections.ObjectModel;

namespace Kanelbullen.Mvvm.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly MemberService _memberService;

        public MainViewModel(MemberService memberService)
        {
            _memberService = memberService;
            Members = new ObservableCollection<MemberModel>()
            {
                new MemberModel() {FirstName}
            }

            //GetMembers();
        }

        private void GetMembers()
        {
            Members.Clear();

            foreach (var member in _memberService.GetMembersFromList())
                Members.Add(member);
        }

        [ObservableProperty]
        private ObservableCollection<MemberModel> members;

        [RelayCommand]
        public async Task GoToDetail()
        {
            await Shell.Current.GoToAsync(nameof(DetailPage));
        }

        [RelayCommand]
        public async Task GoToEdit()
        {
            await Shell.Current.GoToAsync(nameof(EditPage));
        }
    }

}
