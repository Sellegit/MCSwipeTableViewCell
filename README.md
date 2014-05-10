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

			cell.SetSwipeGestureWithView (this.ViewWithImage ("clock.png"), MCSwipe.Colors.Yellow, MCCellMode.Switch, MCCellState.Three, delegate(MCSwipeTableViewCell cll, MCCellState state, MCCellMode mode) {
				Console.WriteLine("Third");
			});

			cell.SetSwipeGestureWithView (this.ViewWithImage ("list.png"), MCSwipe.Colors.Brown, MCCellMode.Switch, MCCellState.Four, delegate(MCSwipeTableViewCell cll, MCCellState state, MCCellMode mode) {
				Console.WriteLine("Fourth");
			});
				
			cell.SetSwipeGestureWithView (this.ViewWithImage ("check.png"), MCSwipe.Colors.Green, MCCellMode.Switch, MCCellState.One, delegate(MCSwipeTableViewCell cll, MCCellState state, MCCellMode mode) {
				Console.WriteLine("First");
			});

			cell.SetSwipeGestureWithView (this.ViewWithImage ("cross.png"), MCSwipe.Colors.Red, MCCellMode.Switch, MCCellState.Two, delegate(MCSwipeTableViewCell cll, MCCellState state, MCCellMode mode) {
				Console.WriteLine("Second");
			});
				
			return cell;
		}



Bugs/Limitations
====================
-When setting 4 States, only 3 seem functional<br />


Credits
====================
-alikaragoz for original MCSwipeTableViewCell