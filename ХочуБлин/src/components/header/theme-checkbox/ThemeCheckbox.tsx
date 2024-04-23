import styles from './theme-checkbox.module.css'
import { useContext } from 'react'
import { ThemeContext, IThemeContext, themes } from 'src/provider/ThemeProvider'

const ThemeCheckbox = () => {
    const { theme, setTheme } = useContext(ThemeContext) as IThemeContext
    return (
        <div
            className={`${styles.wrapper} ${theme === themes.light && styles.active}`}
            onClick={() => {
                if (theme === themes.dark) setTheme(themes.light)
                else setTheme(themes.dark)
            }}
        >
            <img className={styles.icon} src="/theme-moon-icon.svg" />
            <img className={styles.icon} src="/theme-sun-icon.svg" />
        </div>
    )
}

export default ThemeCheckbox
