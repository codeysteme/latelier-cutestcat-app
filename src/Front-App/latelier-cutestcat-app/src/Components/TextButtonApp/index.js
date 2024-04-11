import React from "react";
import { TextField, Button } from "@mui/material";
import { isEmpty } from "ramda";

function TextButtonApp({ setValue, value, handleSubmit, name, placeholder }) {
  return (
    <div id="searchBlock">
      <TextField
        id="filled-hidden-label-normal"
        color="primary"
        variant="outlined"
        placeholder={placeholder}
        size="small"
        value={value}
        onChange={(e) => setValue(e.target.value)}
      />
      <Button
        size="small"
        variant="contained"
        onClick={handleSubmit}
        disabled={isEmpty(value)}
      >
        {name}
      </Button>
    </div>
  );
}

export default TextButtonApp;
