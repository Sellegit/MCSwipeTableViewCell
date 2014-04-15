MCSwipeTableViewCell
====================

A Work-In-Progress Xamarin.iOS Binding of MCSwipeTableViewCell (Swappable UITableViewCell subclass that triggers on swipes, just like the infamous Mailbox app).
<img src="https://raw.github.com/alikaragoz/MCSwipeTableViewCell/master/github-assets/mcswipe-front.png" />

Usage
====================
	public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
	{
		const string cellName = "Cell";
		MCSwipeTableViewCell cell = tableView.DequeueReusableCell (cellName) as MCSwipeTableViewCell;
		if (cell == null) {
			cell = new MCSwipeTableViewCell ();
			cell.SeparatorInset = UIEdgeInsets.Zero;
			cell.ContentView.BackgroundColor = UIColor.Clear;
		}
			
		cell.TextLabel.Text = Titles [indexPath.Row];
		UIView[] Images = new UIView[4] { new UIImageView (UIImage.FromFile ("check.png")), 
			new UIImageView (UIImage.FromFile ("cross.png")),
			new UIImageView (UIImage.FromFile ("clock.png")),
			new UIImageView (UIImage.FromFile ("list.png")) };
				
		UIColor[] Colors = new UIColor[4] { UIColor.FromRGB (85, 213, 80),
			UIColor.FromRGB (232, 61, 14),
			UIColor.FromRGB (254, 217, 56),
			UIColor.FromRGB (206, 149, 98) };
				
		cell.SetSwipeGestureWithView (Images [3], Colors [3], MCCellMode.Switch, MCCellState.Four, delegate {
			Console.WriteLine ("Fourth State");
		});

		cell.SetSwipeGestureWithView (Images [2], Colors [2], MCCellMode.Switch, MCCellState.Three, delegate {
			Console.WriteLine("Third State");
		});

		cell.SetSwipeGestureWithView (Images [0], Colors [0], MCCellMode.Switch, MCCellState.One,delegate {
			Console.WriteLine("First State");
		});

		cell.SetSwipeGestureWithView (Images [1], Colors [1], MCCellMode.Switch, MCCellState.Two, delegate {
			Console.WriteLine("Second State");
		});
								
		return cell;
	}
	

Bugs/Limitations
====================
-When setting 4 States, only 3 seem functional<br />
-Deletion issues<br />


Credits
====================
-alikaragoz for original MCSwipeTableViewCell