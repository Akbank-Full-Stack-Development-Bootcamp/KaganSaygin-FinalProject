import React, { useState, useEffect } from 'react'
import {Link} from 'react-router-dom'
function Publishers() {

    const [publishers, setpublishers] = useState([])
    const [loading, setLoading] = useState(false)
    

    useEffect(() => {
        getpublishers()
    },[])

    const getpublishers = () => {
        setLoading(true)
        fetch("https://localhost:44363/api/publishers")
          .then((response) => response.json())
          .then(json => {
              setpublishers(json)
              setLoading(false)})
    }
        return (

          <div className="card border-info" >
<div className="card-header text-info">
    Yayınevleri
  </div>
           
          <ul className="list-group">
           
              
              {loading ? (
                <div className="d-flex justify-content-center">
                  <div className="spinner-border text-warning" role="status">
                    <span className="visually-hidden">Loading...</span>
                  </div>
                </div>
              ) : (

                publishers.map(function(publishers){
                  return(  
                  <Link to = {'/publishers/'+publishers.id}><li className="list-group-item">{publishers.name}</li></Link>
                  )
                })
              )}
            
          </ul>
        </div>
 )
}

export default Publishers