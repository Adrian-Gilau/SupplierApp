import { useState } from "react";
import axios from "axios";

const API = "https://localhost:7218/api/Suppliers";

interface Supplier {
  code: string;
  name: string;
  telephoneNo: string;
}

function SearchSupplier() {
  const [search, setSearch] = useState("");
  const [result, setResult] = useState<Supplier | null>(null);
  const [message, setMessage] = useState("");

  const handleSearch = async () => {
    setMessage("");
    setResult(null);

    try {
      const response = await axios.get(
        `${API}?search=${encodeURIComponent(search)}`
      );

      setResult(response.data);
    } catch (err: unknown) {
      console.error(err);
      setMessage("Supplier not found.");
    }
  };

  return (
    <div className="card">
      <h2>Search Supplier</h2>

      <input
        placeholder="Company Name"
        value={search}
        onChange={(e) => setSearch(e.target.value)}
      />

      <button className="green" onClick={handleSearch}>
        Search
      </button>

      <p>{message}</p>

      {result && (
        <div className="result">
          <p><strong>Code:</strong> {result.code}</p>
          <p><strong>Name:</strong> {result.name}</p>
          <p><strong>Telephone:</strong> {result.telephoneNo}</p>
        </div>
      )}
    </div>
  );
}

export default SearchSupplier;