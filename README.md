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

			cell.SetSwipeGestureWithView (UIImage.FromFile ("check.png"), MCSwipe.Colors.Green, MCCellMode.Switch, MCCellState.One, delegate {
				Console.WriteLine("First");
			});
			
			cell.SetSwipeGestureWithView (UIImage.FromFile ("cross.png"), MCSwipe.Colors.Red, MCCellMode.Switch, MCCellState.Two, delegate {
				Console.WriteLine("Second");
			});
			
			cell.SetSwipeGestureWithView (UIImage.FromFile ("clock.png"), MCSwipe.Colors.Yellow, MCCellMode.Switch, MCCellState.Three, delegate {
				Console.WriteLine("Third");
			});
			
			cell.SetSwipeGestureWithView (UIImage.FromFile ("list.png"), MCSwipe.Colors.Brown, MCCellMode.Switch, MCCellState.Four, delegate {
				Console.WriteLine("Fourth");
			});
				
			return cell;
		}


Credits
====================
-alikaragoz for original MCSwipeTableViewCell