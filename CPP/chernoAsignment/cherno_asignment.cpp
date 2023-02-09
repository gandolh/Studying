#include <iostream>
#include <sstream>
#include <string>

using std::string;
class HashTable {
public:
    struct Entry {
        string Data;
        string Status = "never used"; 
    };
    static const int Size = 26;

public:
    HashTable() = default;
    void Print();
    void Add(const string&);
    void Delete(const string&);
private:
    Entry m_Entries[Size];
private:
    int GetIndex(const string& entryString);
    int GetInsertIndex(const string& entryString);
    bool Find(const string& , int* outIndex = nullptr);
};

void HashTable::Print() {
    for (int i = 0; i < Size; i++) {
        if(m_Entries[i].Status =="occupied")
        std::cout << m_Entries[i].Data << " " << m_Entries[i].Status << std::endl;
    }
}

void HashTable::Add(const string& entryString) {
    bool exists = Find(entryString);

    if (!exists) {
        int insertIndex = GetInsertIndex(entryString);
        m_Entries[insertIndex].Data = entryString;
        m_Entries[insertIndex].Status = "occupied";
    }

}

void HashTable::Delete(const string& entryString) {
    int index;
    bool exists = Find(entryString,&index);
    if (exists)
        m_Entries[index].Status = "tombstone";
}

int HashTable::GetIndex(const string& entryString)
{

    return entryString.back() - 'a';

}

bool HashTable::Find(const string& entryString,int *outIndex ) {
    bool exists = false;
    int index = GetIndex(entryString);
    int iterations = 0;
    while (iterations <= 27) {
        if (m_Entries[index].Data == entryString) {
            if(outIndex)
                *outIndex = index;
            return true;    
        }
        if (m_Entries[index].Status == "never used" || m_Entries[index].Status == "tombstone")
            return false;
        index = (index + 1) % Size;
        iterations++;
    }
    return false;
}

int HashTable::GetInsertIndex(const string& entryString) {
    int index = GetIndex(entryString);
    int iterations = 0;
    while (iterations<=27) {
        if (m_Entries[index].Status == "never used" || m_Entries[index].Status == "tombstone")
            return index;
        index = (index + 1) % Size;
        iterations++;
    }
    return -1;  
}
int main()
{
    //Aapple Aorange Dapple Agrape Astrwaberry
    string input;
    getline(std::cin, input);
    HashTable hashTable;
    std::stringstream ss(input);
    while (ss.good()) {
        string token;
        ss >> token;
        string entryString = token.substr(1);

        if (token[0] == 'A')
            hashTable.Add(entryString);
        else if (token[0] == 'D')
            hashTable.Delete(entryString);
    }
    
    hashTable.Print();
    return 0;
}

