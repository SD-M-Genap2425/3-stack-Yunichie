namespace Solution.BrowserHistory
{
    public class HistoryNode
    {
        public Halaman Halaman { get; }
        public HistoryNode Next { get; }

        public HistoryNode(Halaman halaman, HistoryNode next = null)
        {
            Halaman = halaman;
            Next = next;
        }
    }

    public class HistoryManager
    {
        private HistoryNode _top;

        public void KunjungiHalaman(string url)
        {
            Halaman newPage = new Halaman(url);
            _top = new HistoryNode(newPage, _top);
        }

        public string Kembali()
        {
            if (_top == null) return "Tidak ada halaman sebelumnya.";

            string previousUrl = _top.Halaman.URL;
            _top = _top.Next;

            if (_top == null) return "Tidak ada halaman sebelumnya.";
            return _top.Halaman.URL;
        }

        public string LihatHalamanSaatIni()
        {
            if (_top == null) return null;
            return _top.Halaman.URL;
        }

        public void TampilkanHistory()
        {
            if (_top == null)
            {
                Console.WriteLine("Tidak ada history.");
                return;
            }

            string currentUrl = _top.Halaman.URL;

            HistoryNode current = _top.Next;
            List<string> reversedUrls = new List<string>();

            while (current != null)
            {
                reversedUrls.Add(current.Halaman.URL);
                current = current.Next;
            }

            for (int i = reversedUrls.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(reversedUrls[i]);
            }
            Console.WriteLine(currentUrl);
        }
    }
}