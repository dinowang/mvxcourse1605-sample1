
----------------------------------------------------------------------------------------------------
15 六月 16 21:11 Add MvvmCross Plugins
----------------------------------------------------------------------------------------------------
Install-Package MvvmCross.Plugin.Color -FileConflictAction ignore -ProjectName Ninja.Core
Install-Package MvvmCross.Plugin.Color -FileConflictAction ignore -ProjectName Ninja.iOS
Install-Package MvvmCross.Plugin.Color -FileConflictAction ignore -ProjectName Ninja.Droid


----------------------------------------------------------------------------------------------------
27 五月 16 16:32 Add ViewModel and Views
----------------------------------------------------------------------------------------------------
PetHouseViewModel.cs added to Ninja.Core project (template=MvxSampleDataViewModel.t4)
PetHouseView.cs added to Ninja.iOS project (template=SampleData\Xib\View.t4)
PetHouseView.cs added to Ninja.Droid project (template=SampleDataView.t4)

----------------------------------------------------------------------------------------------------
25 五月 16 20:42 Add Projects
----------------------------------------------------------------------------------------------------
Ninja.Core project successfully added. (template NinjaCoder.Core.zip)
Ninja.Droid project successfully added. (template NinjaCoder.Droid.zip)
Ninja.iOS project successfully added. (template NinjaCoder.iOS.zip)

----------------------------------------------------------------------------------------------------
Options
----------------------------------------------------------------------------------------------------
MvvmCross framework selected.
NUnit testing framework selected.
Moq mocking framework selected.
iOS View Type Xib selected.

MainViewModel.cs added to Ninja.Core project (template=MvxSampleDataViewModel.t4)
MainView.cs added to Ninja.iOS project (template=SampleData\Xib\View.t4)
MainView.cs added to Ninja.Droid project (template=SampleDataView.t4)

----------------------------------------------------------------------------------------------------
Nuget Commands
----------------------------------------------------------------------------------------------------

Install-Package MvvmCross -FileConflictAction Overwrite -ProjectName Ninja.Core 
Install-Package Scorchio.NinjaCoder.MvvmCross.Core -FileConflictAction Overwrite -ProjectName Ninja.Core 
Install-Package MvvmCross -FileConflictAction Overwrite -ProjectName Ninja.Droid 
Install-Package Scorchio.NinjaCoder.MvvmCross -FileConflictAction ignore -ProjectName Ninja.Droid 
Install-Package MvvmCross -FileConflictAction Overwrite -ProjectName Ninja.iOS 
Install-Package Scorchio.NinjaCoder.MvvmCross -FileConflictAction ignore -ProjectName Ninja.iOS 


----------------------------------------------------------------------------------------------------
Ninja Coder for MvvmCross and Xamarin Forms v4.1.0
----------------------------------------------------------------------------------------------------

All feedback welcome, please get in touch via twitter.

Issues Log http://github.com/asudbury/NinjaCoderForMvvmCross/issues

Thanks

@asudbury
