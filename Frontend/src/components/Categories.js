import React, { useState, useEffect } from 'react'
import {Link} from 'react-router-dom'
function Categories() {

    const [categories, setCategories] = useState([])
    const [loading, setLoading] = useState(false)
    

    useEffect(() => {
        getCategories()
    },[])

    const getCategories = () => {
        setLoading(true)
        fetch("https://localhost:44363/api/categories")
          .then((response) => response.json())
          .then(json => {
              setCategories(json)
              setLoading(false)})
    }
        return (

          <div className="card border-success" >
<div className="card-header text-success">
    Kategoriler
  </div>
           
          <ul className="list-group">
           
              
              {loading ? (
                <div className="d-flex justify-content-center">
                  <div className="spinner-border text-warning" role="status">
                    <span className="visually-hidden">Loading...</span>
                  </div>
                </div>
              ) : (

                categories.map(function(categories){
                  return(  
                  <Link to = {'/categories/'+categories.id}><li className="list-group-item">{categories.name}</li></Link>
                  )
                })
              )}
            
          </ul>
        </div>
 )
}

export default Categories