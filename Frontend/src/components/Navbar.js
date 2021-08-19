import React from 'react'
import {Link} from 'react-router-dom'

export default function Navbar() {
    return (
      <header>
      <nav className="navbar navbar-expand-lg navbar-dark bg-primary">
      <div className="container">        
        <a className="navbar-brand d-flex align-items-center" href="http://localhost:3000">Book Store</a>
        <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
          <span className="navbar-toggler-icon"></span>
        </button>

        

      </div>
    </nav>
    </header>
    )
}
