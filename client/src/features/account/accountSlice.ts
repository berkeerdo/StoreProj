import { createAsyncThunk, createSlice, isAnyOf } from "@reduxjs/toolkit";
import { User } from "../../app/models/user";
import { FieldValues } from "react-hook-form";
import agent from "../../app/api/agent";
import { router } from "../../app/router/Routes";

interface AccountState {
  user: User | null;
}

const initialState: AccountState = {
  user: null,
};

export const signInUser = createAsyncThunk<User, FieldValues>(
  "account/signInUser",
  async (data, thunkAPI) => {
    try {
      const user = await agent.Account.login(data);
      localStorage.setItem("user", JSON.stringify(user));
      return user;
    } catch (error: any) {
      return thunkAPI.rejectWithValue({ error: error.message });
    }
  }
);

export const fetchCurrentUser = createAsyncThunk<User>(
  "account/signInUser",
  async (_, thunkAPI) => {
    try {
      const user = await agent.Account.current();
      localStorage.setItem("user", JSON.stringify(user));
      return user;
    } catch (error: any) {
      return thunkAPI.rejectWithValue({ error: error.message });
    }
  }
);

export const accountSlice = createSlice({
  name: "account",
  initialState,
  reducers: {
    signOutUser: (state) => {
      localStorage.removeItem("user");
      state.user = null;
      router.navigate("/");
    },
  },
  extraReducers: (builder) => {
    builder.addMatcher(
      isAnyOf(signInUser.fulfilled, fetchCurrentUser.fulfilled),
      (state, action) => {
        state.user = action.payload;
      }
    );
    builder.addMatcher(
      isAnyOf(signInUser.rejected, fetchCurrentUser.rejected),
      (state, action) => {
        console.log(action.payload);
      }
    );
  },
});

export const { signOutUser } = accountSlice.actions;