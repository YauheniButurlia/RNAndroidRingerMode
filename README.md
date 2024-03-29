
# react-native-android-ringer-mode

## Getting started

`$ npm install react-native-android-ringer-mode --save`

### Mostly automatic installation

`$ react-native link react-native-android-ringer-mode`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-android-ringer-mode` and add `RNAndroidRingerMode.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNAndroidRingerMode.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNAndroidRingerModePackage;` to the imports at the top of the file
  - Add `new RNAndroidRingerModePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-android-ringer-mode'
  	project(':react-native-android-ringer-mode').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-android-ringer-mode/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-android-ringer-mode')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNAndroidRingerMode.sln` in `node_modules/react-native-android-ringer-mode/windows/RNAndroidRingerMode.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Android.Ringer.Mode.RNAndroidRingerMode;` to the usings at the top of the file
  - Add `new RNAndroidRingerModePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNAndroidRingerMode from 'react-native-android-ringer-mode';

// TODO: What to do with the module?
RNAndroidRingerMode;
```
  