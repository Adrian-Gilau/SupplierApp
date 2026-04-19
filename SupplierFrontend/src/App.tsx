import AddSupplier from "./components/AddSupplier";
import SearchSupplier from "./components/SearchSupplier";
import "./index.css";

function App() {
  return (
    <div className="page">
      <div className="container">
        <h1>Supplier Management Portal</h1>
        <p className="subtitle">
          Sales staff can add and search suppliers from anywhere
        </p>

        <div className="grid">
          <AddSupplier />
          <SearchSupplier />
        </div>
      </div>
    </div>
  );
}

export default App;