MCSwipeTableViewCell
====================

A Xamarin.iOS Binding of MCSwipeTableViewCell (Swappable UITableViewCell subclass that triggers on swipes, just like the infamous Mailbox app).
<img src="https://raw.github.com/alikaragoz/MCSwipeTableViewCell/master/github-assets/mcswipe-front.png" />

Modes
====================
###Switch Mode
<img src="https://raw.github.com/alikaragoz/MCSwipeTableViewCell/master/github-assets/mcswipe-switch.gif" />
###Exit Mode
<img src="https://raw.github.com/alikaragoz/MCSwipeTableViewCell/master/github-assets/mcswipe-exit.gif" />


Usage
====================
	using MCSwipe;
	//[...]
			
	public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
			{
			const string cellName = "Cell";

			MCSwipeTableViewCell cell = tableView.DequeueReusableCell (cellName) as MCSwipeTableViewCell;
			if (cell == null) {
				cell = new MCSwipeTableViewCell (UITableViewCellStyle.Subtitle, cellName);
				cell.SeparatorInset = UIEdgeInsets.Zero;
				cell.DefaultColor = UIColor.White;
			}
				
			cell.TextLabel.Text = cell.DetailTextLabel.Text = String.Format("Swipe Mode Cell {0}", indexPath.Row);

			cell.SetFirst(UIImage.FromFile("check.png"), UIColor.FromRGB(85, 213, 80), MCCellMode.Switch, delegate {
				Console.WriteLine("Checkmark");
			});
			
			cell.SetSecond(UIImage.FromFile("cross.png"), UIColor.FromRGB(232,61,14), MCCellMode.Switch, delegate {
				Console.WriteLine("Cross");
			});
			
			cell.SetThird(UIImage.FromFile("clock.png"), UIColor.FromRGB(254,217,56), MCCellMode.Switch, delegate {
				Console.WriteLine("Clock");
			});
			
			cell.SetFourth(UIImage.FromFile("list.png"), UIColor.FromRGB(206,149,98), MCCellMode.Switch, delegate {
				Console.WriteLine("List");
			});
				
			return cell;
		}


Credits
====================
-alikaragoz for original MCSwipeTableViewCell