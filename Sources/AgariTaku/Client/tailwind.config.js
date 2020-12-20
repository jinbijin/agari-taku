const colors = require('tailwindcss/colors');

module.exports = {
  purge: [],
  darkMode: false, // or 'media' or 'class'
  theme: {
    extend: {},
    colors: {
      primary: colors.emerald,
      accent: colors.blue,
      white: '#FFFFFF',
    },
  },
  variants: {
    extend: {},
  },
  plugins: [],
}
