import { useState } from "react";
import axios from "axios";

const API = "https://localhost:7218/api/Suppliers";

function AddSupplier() {
  const [code, setCode] = useState("");
  const [name, setName] = useState("");
  const [telephoneNo, setTelephoneNo] = useState("");
  const [message, setMessage] = useState("");

  const saveSupplier = async () => {
    setMessage("");

    try {
      await axios.post(API, {
        code: Number(code),
        name,
        telephoneNo,
      });

      setMessage("Supplier saved successfully.");
      setCode("");
      setName("");
      setTelephoneNo("");
    } catch (err: unknown) {
      console.error(err);
      setMessage("Failed to save supplier.");
    }
  };

  return (
    <div className="card">
      <h2>Add Supplier</h2>

      <input
        placeholder="Code"
        value={code}
        onChange={(e) => setCode(e.target.value)}
      />

      <input
        placeholder="Company Name"
        value={name}
        onChange={(e) => setName(e.target.value)}
      />

      <input
        placeholder="Telephone Number"
        value={telephoneNo}
        onChange={(e) => setTelephoneNo(e.target.value)}
      />

      <button onClick={saveSupplier}>Save Supplier</button>

      <p>{message}</p>
    </div>
  );
}

export default AddSupplier;