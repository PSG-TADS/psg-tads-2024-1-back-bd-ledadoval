import React from 'react';
import ReactDOM from 'react-dom/client'; // Importando createRoot
import App from './App';

const root = ReactDOM.createRoot(document.getElementById('root')); // Usando createRoot
root.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);
