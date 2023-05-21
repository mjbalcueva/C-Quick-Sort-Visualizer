namespace Group4FinalsExamAlgo
{
    public partial class VisualQuickSort : Form
    {
        public VisualQuickSort()
        {
            InitializeComponent();
        }

        private int[] _numbersToSort;
        private int _pivotIndex;
        private int _leftIndex;
        private int _rightIndex;
        private readonly Stack<int> _stack = new Stack<int>();
        private List<int> _movedNumbers = new List<int>();

        private void BtnSort_Click(object sender, EventArgs e)
        {
            ListBoxSteps.Items.Clear();
            BtnForward.Enabled = true;
            _numbersToSort = Array.ConvertAll(TextBoxNumbersToSort.Text.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            ListBoxSteps.Items.Add(string.Join(" ", AddBracketsToMovedNumbers(_numbersToSort)));
            _stack.Push(0);
            _stack.Push(_numbersToSort.Length - 1);
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            if (_stack.Count <= 0)
            {
                ListBoxSteps.Items.Add(string.Join(" ", _numbersToSort));
                BtnForward.Enabled = false;
            }
            else
            {
                _rightIndex = _stack.Pop();
                _leftIndex = _stack.Pop();
                _pivotIndex = Partition(_leftIndex, _rightIndex);

                if (_pivotIndex - 1 > _leftIndex)
                {
                    _stack.Push(_leftIndex);
                    _stack.Push(_pivotIndex - 1);
                }

                if (_pivotIndex + 1 < _rightIndex)
                {
                    _stack.Push(_pivotIndex + 1);
                    _stack.Push(_rightIndex);
                }

                if (ListBoxSteps.Items.Count != 0 && string.Join(" ", AddBracketsToMovedNumbers(_numbersToSort)) ==
                    ListBoxSteps.Items.ToString()) return;
                ListBoxSteps.Items.Add(string.Join(" ", AddBracketsToMovedNumbers(_numbersToSort)));
                _movedNumbers.Clear();
            }
        }


        private int Partition(int left, int right)
        {
            var pivot = _numbersToSort[right];
            var i = left - 1;

            for (var j = left; j < right; j++)
            {
                if (_numbersToSort[j] < pivot)
                {
                    i++;
                    Swap(ref _numbersToSort[i], ref _numbersToSort[j]);
                    if (!_movedNumbers.Contains(_numbersToSort[i]))
                        _movedNumbers.Add(_numbersToSort[i]);
                    if (!_movedNumbers.Contains(_numbersToSort[j]))
                        _movedNumbers.Add(_numbersToSort[j]);
                }
            }
            Swap(ref _numbersToSort[i + 1], ref _numbersToSort[right]);
            if (!_movedNumbers.Contains(_numbersToSort[i + 1]))
                _movedNumbers.Add(_numbersToSort[i + 1]);
            if (!_movedNumbers.Contains(_numbersToSort[right]))
                _movedNumbers.Add(_numbersToSort[right]);
            return i + 1;
        }

        private void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ListBoxSteps.Items.Clear();
            TextBoxNumbersToSort.Clear();
            _movedNumbers.Clear();
            BtnForward.Enabled = true;
        }

        private string[] AddBracketsToMovedNumbers(int[] numbers)
        {
            string[] result = new string[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (_movedNumbers.Contains(numbers[i]))
                    result[i] = "[" + numbers[i].ToString() + "]";
                else
                    result[i] = numbers[i].ToString();
            }
            return result;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            BtnClear_Click(sender, e);
            var random = new Random();
            var randomNumbers = new int[10];
            for (var i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(1, 100);
            }
            TextBoxNumbersToSort.Text = string.Join(", ", randomNumbers);
        }
    }
}
