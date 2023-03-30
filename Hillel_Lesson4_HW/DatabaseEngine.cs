namespace Hillel_lesson4_HW;

public class DatabaseEngine<T>
{
    private T _value;
    private string _password;


    public T Value
    {
        get
        {
            return _value;
        }
        set
        {
            _value = value;
        }
    }

    public string Password
    {
        get
        {
            return _password;
        }
        set
        {
            _password = value;
        }
    }
    
    
    
    public class DatabaseValue
    {
        private T _value;
        private string _tableName;


        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public string TableName
        {
            get
            {
                return _tableName;
            }
            set
            {
                _tableName = value;
            }
        }

        public DatabaseValue (T value, string tableName)
        {
            _value = value;
            _tableName = tableName;
        }

        public DatabaseValue()
        {
            
        }
        

    }

    public void WriteValue(T value, string password)
    {
        _value = value;
        _password = password;

        DatabaseValue databaseValue = new DatabaseValue();
        
    }
    
    
    
}