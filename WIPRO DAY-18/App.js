import './App.css';
import { FuncCounter } from './FuncCounter.js';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import ListImages from './ListImgs.js';  // Corrected to default import
import { Employee } from './Employee.js';
import { BookList } from './BookList';  // Import BookList here

function App() {
  return (
    <div>
      <Router>
        <nav>
          <Link to="/FuncCounter">FuncCounter</Link> |
          <Link to="/Employee"> Employee</Link> |
          <Link to="/ListImgs"> Images</Link> |
          <Link to="/BookList"> BookList</Link>  {/* Link to BookList */}
        </nav>
        <Routes>
          <Route path="/" element={<Employee />} />
          <Route path="/FuncCounter" element={<FuncCounter />} />
          <Route path="/ListImgs" element={<ListImages />} />
          <Route path="/BookList" element={<BookList />} /> {/* Route for BookList */}
        </Routes>
      </Router>
    </div>
  );
}

export default App;
