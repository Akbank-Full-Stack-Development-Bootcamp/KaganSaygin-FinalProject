import React, { useState } from 'react'

const Search = (props) => {
    const [term, setTerm] = useState("")
    const handleOnSubmit = (event) => {
        event.preventDefault()
        props.searchBook(term)        
    }

    const handleOnChange = (event) => {
        setTerm(event.target.value)
    }        
        return (
            <form onSubmit={handleOnSubmit} className="row g-3 mb-5">
                <div className="col-10">
                    <input onChange={handleOnChange} type="text" className="form-control form-control-lg" placeholder="Kitap / Yazar / Yayınevi Ara..." value={term}/>
                </div>
                <div className="col-2">
                <input type="submit" value="Ara" className="form-control btn-lg btn btn-primary text-white"disabled = {!(term)}/>
                </div>
            </form>
        );
}

export default Search