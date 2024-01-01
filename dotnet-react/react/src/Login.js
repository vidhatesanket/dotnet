export default function handleSumbit(movie) {
    
    const data = {
      Id: uuid(),
      Title: movie.title,
      MovieLanguage: movie.movieLanguage,
      ReleaseYear: movie.releaseYear,
      OTT: movie.ott,
    };
    axios({
      method: "post",
      url: "http://localhost:5159/api/movies",
      data: data,
      config: {
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
        },
      },
    })
      .then((response) => {
        console.log(response);
        toast.success("Movie added successfully", {
          position: toast.POSITION.TOP_RIGHT,
        });
      })
      .catch((error) => {
        console.log("the error has occured: " + error);
      });

    setMovies([...movies, data]);
  }