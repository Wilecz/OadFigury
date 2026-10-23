private readonly List<Product> all = new();
public ObservableCollection<Product> Seen {get;} = new();

private void Refresh()
{
    Seen.Clear();
    foreach (var p in Browser.Search(all, SearchArea.Text))
        Seen.Add(p);
}
private void SearchArea_TextChanged(object sender, TextChangedEventArgs e) => Refresh();
