class SimpleBaseData<T>() {
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase() {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data){ 
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData() {
        for (int i = 0; i < storedData.Count; i++) {
            Console.WriteLine(storedData[i] + " " + inputDates[i]);
        }
    }
}

class main() { 
    SimpleBaseData<int> test = new SimpleBaseData<int>();
    test.AddNewData(10);
}